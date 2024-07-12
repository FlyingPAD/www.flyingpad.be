import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TagDetailsFlowComponent } from './tag-details-flow.component';

describe('TagDetailsFlowComponent', () => {
  let component: TagDetailsFlowComponent;
  let fixture: ComponentFixture<TagDetailsFlowComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [TagDetailsFlowComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TagDetailsFlowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
