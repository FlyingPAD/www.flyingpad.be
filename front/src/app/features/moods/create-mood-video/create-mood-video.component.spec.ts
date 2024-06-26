import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateMoodVideoComponent } from './create-mood-video.component';

describe('CreateMoodVideoComponent', () => {
  let component: CreateMoodVideoComponent;
  let fixture: ComponentFixture<CreateMoodVideoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CreateMoodVideoComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CreateMoodVideoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
