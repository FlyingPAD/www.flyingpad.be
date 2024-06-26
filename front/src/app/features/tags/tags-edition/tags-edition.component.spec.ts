import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TagsEditionComponent } from './tags-edition.component';

describe('TagsEditionComponent', () => {
  let component: TagsEditionComponent;
  let fixture: ComponentFixture<TagsEditionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [TagsEditionComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TagsEditionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
