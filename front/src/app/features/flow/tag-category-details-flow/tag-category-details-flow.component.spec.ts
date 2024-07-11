import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TagCategoryDetailsFlowComponent } from './tag-category-details-flow.component';

describe('TagCategoryDetailsFlowComponent', () => {
  let component: TagCategoryDetailsFlowComponent;
  let fixture: ComponentFixture<TagCategoryDetailsFlowComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [TagCategoryDetailsFlowComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TagCategoryDetailsFlowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
